import { FormGroup } from '@angular/forms'

export class GenericValidator {
    constructor(private validationMessage: {
        [key: string] : {[key: string]: string} }) { }

    processMessages(container: FormGroup): { [key: string]: string} {
        let messages = {};
        for(let controlKey in container.controls) {
            if(container.controls.hasOwnProperty(controlKey)) {
                let c = container.controls[controlKey];

                if(c instanceof FormGroup){
                    let childMessage = this.processMessages(c);
                    Object.assign(messages, childMessage);
                } else {
                    if(this.validationMessage[controlKey]) {
                        messages[controlKey] = '';
                        if((c.dirty || c.touched) && c.errors){
                            Object.keys(c.errors).map(messageKey => {
                                if(this.validationMessage[controlKey][messageKey]){
                                    messages[controlKey] += this.validationMessage[controlKey][messageKey] + '<br />';
                                }
                            });
                        }
                    }
                }
            }
        }
        return messages;
    }
}
export class stringUtils {
    
    public static isNullOrEmpty(val: string) : boolean {
        if(val === undefined || val === null || val.trim() === '') {
            return true;
        }
        return false;
    };
}
import { Injectable } from '@angular/core';
import { Meta, Title } from '@angular/platform-browser';
import { stringUtils } from '../utils/string.utils';

@Injectable()
export class SeoService {

    public constructor(private title: Title, private meta: Meta) {}

    public setSeoData(seoModel: SeoModel){
        this.setTitle(seoModel.title);
        this.setMetaRobots(seoModel.robots);
        this.setMetaDescription(seoModel.description);
        this.setMetakeywords(seoModel.keywords);
    }

    private setTitle(newTitle: string) {
        if(stringUtils.isNullOrEmpty(newTitle)) {
            newTitle = "Defina um Título";
        }
        this.title.setTitle(newTitle + " - Eventos.IO")
    }

    private setMetaDescription(description: string) {
       if(stringUtils.isNullOrEmpty(description)) {
            description = "Aqui você encontra um evento técnico próximo de você";
        }
        this.meta.updateTag({ name: 'description', content: description });
    }

    private setMetaRobots(robots: string) {
        if(stringUtils.isNullOrEmpty(robots)) {
            robots = "all";
        }
        this.meta.updateTag({ name: 'robots', content: robots });
    }

    private setMetakeywords(keywords: string) {
        if(stringUtils.isNullOrEmpty(keywords)) {
            keywords = "eventos,workshops,encontros,congressos,comunidades,tecnologias";
        }
        this.meta.updateTag({ name: 'keywords', content: keywords });
    }
}

export class SeoModel {
    public title: string = '';
    public robots: string = '';
    public description: string = '';
    public keywords: string = '';
}
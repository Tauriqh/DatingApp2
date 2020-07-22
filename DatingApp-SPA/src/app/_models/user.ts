import { Photo } from './photo';

export interface User {
    id: number;
    username: string;
    knownAs: string;
    age: number;
    gender: string;
    created: Date;
    lastActive: Date;
    photoUrl: Date;
    city: Date;
    country: Date;
    interests?: string;
    introduction?: string;
    lookingFor?: string;
    photos?: Photo[];
}

export interface Reviews {
    userId: number;
    ReviewListbyUser: ReviewListbyUser[];
  }
  
  export interface ReviewListbyUser {
    id: number;
    Rating: number;
    ReviewText: string;
    releaseDate: Date;
  }
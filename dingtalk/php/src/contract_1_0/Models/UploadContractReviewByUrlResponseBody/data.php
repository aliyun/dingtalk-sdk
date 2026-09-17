<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\UploadContractReviewByUrlResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\UploadContractReviewByUrlResponseBody\data\recommended;
use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\UploadContractReviewByUrlResponseBody\data\weboffice;
use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @var string
     */
    public $overviewSummary;

    /**
     * @var bool
     */
    public $recommendationFallback;

    /**
     * @var recommended
     */
    public $recommended;

    /**
     * @var string
     */
    public $reviewId;

    /**
     * @var weboffice
     */
    public $weboffice;
    protected $_name = [
        'overviewSummary' => 'overview_summary',
        'recommendationFallback' => 'recommendation_fallback',
        'recommended' => 'recommended',
        'reviewId' => 'review_id',
        'weboffice' => 'weboffice',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->overviewSummary) {
            $res['overview_summary'] = $this->overviewSummary;
        }
        if (null !== $this->recommendationFallback) {
            $res['recommendation_fallback'] = $this->recommendationFallback;
        }
        if (null !== $this->recommended) {
            $res['recommended'] = null !== $this->recommended ? $this->recommended->toMap() : null;
        }
        if (null !== $this->reviewId) {
            $res['review_id'] = $this->reviewId;
        }
        if (null !== $this->weboffice) {
            $res['weboffice'] = null !== $this->weboffice ? $this->weboffice->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return data
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['overview_summary'])) {
            $model->overviewSummary = $map['overview_summary'];
        }
        if (isset($map['recommendation_fallback'])) {
            $model->recommendationFallback = $map['recommendation_fallback'];
        }
        if (isset($map['recommended'])) {
            $model->recommended = recommended::fromMap($map['recommended']);
        }
        if (isset($map['review_id'])) {
            $model->reviewId = $map['review_id'];
        }
        if (isset($map['weboffice'])) {
            $model->weboffice = weboffice::fromMap($map['weboffice']);
        }

        return $model;
    }
}

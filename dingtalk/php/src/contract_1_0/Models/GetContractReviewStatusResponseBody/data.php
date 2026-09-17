<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\GetContractReviewStatusResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\GetContractReviewStatusResponseBody\data\riskCounts;
use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\GetContractReviewStatusResponseBody\data\topRisks;
use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @var string
     */
    public $message;

    /**
     * @var int
     */
    public $progressPct;

    /**
     * @var string
     */
    public $reviewId;

    /**
     * @var riskCounts
     */
    public $riskCounts;

    /**
     * @var string
     */
    public $status;

    /**
     * @var topRisks[]
     */
    public $topRisks;

    /**
     * @var string
     */
    public $webofficeUrl;
    protected $_name = [
        'message' => 'message',
        'progressPct' => 'progress_pct',
        'reviewId' => 'review_id',
        'riskCounts' => 'risk_counts',
        'status' => 'status',
        'topRisks' => 'top_risks',
        'webofficeUrl' => 'weboffice_url',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->message) {
            $res['message'] = $this->message;
        }
        if (null !== $this->progressPct) {
            $res['progress_pct'] = $this->progressPct;
        }
        if (null !== $this->reviewId) {
            $res['review_id'] = $this->reviewId;
        }
        if (null !== $this->riskCounts) {
            $res['risk_counts'] = null !== $this->riskCounts ? $this->riskCounts->toMap() : null;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->topRisks) {
            $res['top_risks'] = [];
            if (null !== $this->topRisks && \is_array($this->topRisks)) {
                $n = 0;
                foreach ($this->topRisks as $item) {
                    $res['top_risks'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->webofficeUrl) {
            $res['weboffice_url'] = $this->webofficeUrl;
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
        if (isset($map['message'])) {
            $model->message = $map['message'];
        }
        if (isset($map['progress_pct'])) {
            $model->progressPct = $map['progress_pct'];
        }
        if (isset($map['review_id'])) {
            $model->reviewId = $map['review_id'];
        }
        if (isset($map['risk_counts'])) {
            $model->riskCounts = riskCounts::fromMap($map['risk_counts']);
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['top_risks'])) {
            if (!empty($map['top_risks'])) {
                $model->topRisks = [];
                $n = 0;
                foreach ($map['top_risks'] as $item) {
                    $model->topRisks[$n++] = null !== $item ? topRisks::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['weboffice_url'])) {
            $model->webofficeUrl = $map['weboffice_url'];
        }

        return $model;
    }
}

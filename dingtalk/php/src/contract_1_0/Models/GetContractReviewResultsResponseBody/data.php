<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\GetContractReviewResultsResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\GetContractReviewResultsResponseBody\data\report;
use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\GetContractReviewResultsResponseBody\data\riskCounts;
use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @var string
     */
    public $annotatedExportUrl;

    /**
     * @var string
     */
    public $message;

    /**
     * @var report
     */
    public $report;

    /**
     * @var string
     */
    public $reportExportUrl;

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
     * @var int
     */
    public $totalRisks;

    /**
     * @var string
     */
    public $webofficeUrl;
    protected $_name = [
        'annotatedExportUrl' => 'annotated_export_url',
        'message' => 'message',
        'report' => 'report',
        'reportExportUrl' => 'report_export_url',
        'reviewId' => 'review_id',
        'riskCounts' => 'risk_counts',
        'status' => 'status',
        'totalRisks' => 'total_risks',
        'webofficeUrl' => 'weboffice_url',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->annotatedExportUrl) {
            $res['annotated_export_url'] = $this->annotatedExportUrl;
        }
        if (null !== $this->message) {
            $res['message'] = $this->message;
        }
        if (null !== $this->report) {
            $res['report'] = null !== $this->report ? $this->report->toMap() : null;
        }
        if (null !== $this->reportExportUrl) {
            $res['report_export_url'] = $this->reportExportUrl;
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
        if (null !== $this->totalRisks) {
            $res['total_risks'] = $this->totalRisks;
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
        if (isset($map['annotated_export_url'])) {
            $model->annotatedExportUrl = $map['annotated_export_url'];
        }
        if (isset($map['message'])) {
            $model->message = $map['message'];
        }
        if (isset($map['report'])) {
            $model->report = report::fromMap($map['report']);
        }
        if (isset($map['report_export_url'])) {
            $model->reportExportUrl = $map['report_export_url'];
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
        if (isset($map['total_risks'])) {
            $model->totalRisks = $map['total_risks'];
        }
        if (isset($map['weboffice_url'])) {
            $model->webofficeUrl = $map['weboffice_url'];
        }

        return $model;
    }
}

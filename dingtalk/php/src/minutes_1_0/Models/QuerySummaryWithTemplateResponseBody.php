<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models;

use AlibabaCloud\Tea\Model;

class QuerySummaryWithTemplateResponseBody extends Model
{
    /**
     * @var string
     */
    public $generatingStatus;

    /**
     * @var string
     */
    public $summaryText;

    /**
     * @var string
     */
    public $visualGeneratingStatus;
    protected $_name = [
        'generatingStatus' => 'generatingStatus',
        'summaryText' => 'summaryText',
        'visualGeneratingStatus' => 'visualGeneratingStatus',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->generatingStatus) {
            $res['generatingStatus'] = $this->generatingStatus;
        }
        if (null !== $this->summaryText) {
            $res['summaryText'] = $this->summaryText;
        }
        if (null !== $this->visualGeneratingStatus) {
            $res['visualGeneratingStatus'] = $this->visualGeneratingStatus;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QuerySummaryWithTemplateResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['generatingStatus'])) {
            $model->generatingStatus = $map['generatingStatus'];
        }
        if (isset($map['summaryText'])) {
            $model->summaryText = $map['summaryText'];
        }
        if (isset($map['visualGeneratingStatus'])) {
            $model->visualGeneratingStatus = $map['visualGeneratingStatus'];
        }

        return $model;
    }
}

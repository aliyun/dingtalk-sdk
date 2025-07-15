<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models;

use AlibabaCloud\Tea\Model;

class OpenQueryMinutesSummaryResponseBody extends Model
{
    /**
     * @var string
     */
    public $fullSummary;
    protected $_name = [
        'fullSummary' => 'fullSummary',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->fullSummary) {
            $res['fullSummary'] = $this->fullSummary;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return OpenQueryMinutesSummaryResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['fullSummary'])) {
            $model->fullSummary = $map['fullSummary'];
        }

        return $model;
    }
}

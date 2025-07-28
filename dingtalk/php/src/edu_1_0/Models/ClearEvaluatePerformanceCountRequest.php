<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class ClearEvaluatePerformanceCountRequest extends Model
{
    /**
     * @var string[]
     */
    public $studentIdList;
    protected $_name = [
        'studentIdList' => 'studentIdList',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->studentIdList) {
            $res['studentIdList'] = $this->studentIdList;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ClearEvaluatePerformanceCountRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['studentIdList'])) {
            if (!empty($map['studentIdList'])) {
                $model->studentIdList = $map['studentIdList'];
            }
        }

        return $model;
    }
}

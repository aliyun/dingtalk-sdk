<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetDocCreatedSummaryResponseBody extends Model
{
    /**
     * @description 最近1天累计创建文档数
     *
     * @var string
     */
    public $docCreatedCnt;
    protected $_name = [
        'docCreatedCnt' => 'docCreatedCnt',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->docCreatedCnt) {
            $res['docCreatedCnt'] = $this->docCreatedCnt;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetDocCreatedSummaryResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['docCreatedCnt'])) {
            $model->docCreatedCnt = $map['docCreatedCnt'];
        }

        return $model;
    }
}

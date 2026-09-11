<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryServiceRecordLocationRequest extends Model
{
    /**
     * @var int
     */
    public $locationAmountLimit;

    /**
     * @var string[]
     */
    public $recordIdList;
    protected $_name = [
        'locationAmountLimit' => 'locationAmountLimit',
        'recordIdList' => 'recordIdList',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->locationAmountLimit) {
            $res['locationAmountLimit'] = $this->locationAmountLimit;
        }
        if (null !== $this->recordIdList) {
            $res['recordIdList'] = $this->recordIdList;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryServiceRecordLocationRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['locationAmountLimit'])) {
            $model->locationAmountLimit = $map['locationAmountLimit'];
        }
        if (isset($map['recordIdList'])) {
            if (!empty($map['recordIdList'])) {
                $model->recordIdList = $map['recordIdList'];
            }
        }

        return $model;
    }
}

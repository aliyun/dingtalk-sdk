<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryServiceRecordLocationShrinkRequest extends Model
{
    /**
     * @var int
     */
    public $locationAmountLimit;

    /**
     * @var string
     */
    public $recordIdListShrink;
    protected $_name = [
        'locationAmountLimit' => 'locationAmountLimit',
        'recordIdListShrink' => 'recordIdList',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->locationAmountLimit) {
            $res['locationAmountLimit'] = $this->locationAmountLimit;
        }
        if (null !== $this->recordIdListShrink) {
            $res['recordIdList'] = $this->recordIdListShrink;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryServiceRecordLocationShrinkRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['locationAmountLimit'])) {
            $model->locationAmountLimit = $map['locationAmountLimit'];
        }
        if (isset($map['recordIdList'])) {
            $model->recordIdListShrink = $map['recordIdList'];
        }

        return $model;
    }
}

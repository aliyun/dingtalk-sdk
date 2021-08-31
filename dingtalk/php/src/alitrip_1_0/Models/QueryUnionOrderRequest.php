<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryUnionOrderRequest extends Model
{
    /**
     * @description 第三方企业id
     *
     * @var string
     */
    public $corpId;

    /**
     * @description 第三方申请单id
     *
     * @var string
     */
    public $thirdPartApplyId;

    /**
     * @description 关联单号
     *
     * @var string
     */
    public $unionNo;
    protected $_name = [
        'corpId'           => 'corpId',
        'thirdPartApplyId' => 'thirdPartApplyId',
        'unionNo'          => 'unionNo',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->thirdPartApplyId) {
            $res['thirdPartApplyId'] = $this->thirdPartApplyId;
        }
        if (null !== $this->unionNo) {
            $res['unionNo'] = $this->unionNo;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryUnionOrderRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['thirdPartApplyId'])) {
            $model->thirdPartApplyId = $map['thirdPartApplyId'];
        }
        if (isset($map['unionNo'])) {
            $model->unionNo = $map['unionNo'];
        }

        return $model;
    }
}

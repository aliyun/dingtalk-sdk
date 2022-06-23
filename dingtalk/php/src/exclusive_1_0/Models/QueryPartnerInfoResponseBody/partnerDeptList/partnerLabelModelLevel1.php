<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\QueryPartnerInfoResponseBody\partnerDeptList;

use AlibabaCloud\Tea\Model;

class partnerLabelModelLevel1 extends Model
{
    /**
     * @description 标签id
     *
     * @var int
     */
    public $labelId;

    /**
     * @description 标签名称
     *
     * @var string
     */
    public $labelname;
    protected $_name = [
        'labelId'   => 'labelId',
        'labelname' => 'labelname',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->labelId) {
            $res['labelId'] = $this->labelId;
        }
        if (null !== $this->labelname) {
            $res['labelname'] = $this->labelname;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return partnerLabelModelLevel1
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['labelId'])) {
            $model->labelId = $map['labelId'];
        }
        if (isset($map['labelname'])) {
            $model->labelname = $map['labelname'];
        }

        return $model;
    }
}

<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class SetDeptPartnerTypeAndNumRequest extends Model
{
    /**
     * @description 部门id
     *
     * @var string
     */
    public $deptId;

    /**
     * @description 伙伴编码
     *
     * @var string
     */
    public $partnerNum;

    /**
     * @description 伙伴类型id列表
     *
     * @var string[]
     */
    public $labelIds;
    protected $_name = [
        'deptId'     => 'deptId',
        'partnerNum' => 'partnerNum',
        'labelIds'   => 'labelIds',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->deptId) {
            $res['deptId'] = $this->deptId;
        }
        if (null !== $this->partnerNum) {
            $res['partnerNum'] = $this->partnerNum;
        }
        if (null !== $this->labelIds) {
            $res['labelIds'] = $this->labelIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SetDeptPartnerTypeAndNumRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deptId'])) {
            $model->deptId = $map['deptId'];
        }
        if (isset($map['partnerNum'])) {
            $model->partnerNum = $map['partnerNum'];
        }
        if (isset($map['labelIds'])) {
            if (!empty($map['labelIds'])) {
                $model->labelIds = $map['labelIds'];
            }
        }

        return $model;
    }
}

<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class SendInvitationRequest extends Model
{
    /**
     * @description 部门id
     *
     * @var string
     */
    public $deptId;

    /**
     * @description 组织别名
     *
     * @var string
     */
    public $orgAlias;

    /**
     * @description 伙伴标签id
     *
     * @var int
     */
    public $partnerLabelId;

    /**
     * @description 伙伴编码
     *
     * @var string
     */
    public $partnerNum;

    /**
     * @description 手机号
     *
     * @var string
     */
    public $phone;
    protected $_name = [
        'deptId'         => 'deptId',
        'orgAlias'       => 'orgAlias',
        'partnerLabelId' => 'partnerLabelId',
        'partnerNum'     => 'partnerNum',
        'phone'          => 'phone',
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
        if (null !== $this->orgAlias) {
            $res['orgAlias'] = $this->orgAlias;
        }
        if (null !== $this->partnerLabelId) {
            $res['partnerLabelId'] = $this->partnerLabelId;
        }
        if (null !== $this->partnerNum) {
            $res['partnerNum'] = $this->partnerNum;
        }
        if (null !== $this->phone) {
            $res['phone'] = $this->phone;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SendInvitationRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deptId'])) {
            $model->deptId = $map['deptId'];
        }
        if (isset($map['orgAlias'])) {
            $model->orgAlias = $map['orgAlias'];
        }
        if (isset($map['partnerLabelId'])) {
            $model->partnerLabelId = $map['partnerLabelId'];
        }
        if (isset($map['partnerNum'])) {
            $model->partnerNum = $map['partnerNum'];
        }
        if (isset($map['phone'])) {
            $model->phone = $map['phone'];
        }

        return $model;
    }
}

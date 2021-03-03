<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\CreateApproveRequest\punchParam;
use AlibabaCloud\Tea\Model;

class CreateApproveRequest extends Model
{
    /**
     * @description 员工id
     *
     * @var string
     */
    public $userid;

    /**
     * @description 审批单类型名称，最大长度20个字符
     *
     * @var string
     */
    public $tagName;

    /**
     * @description 子类型名称，最大长度20个字符
     *
     * @var string
     */
    public $subType;

    /**
     * @description 审批单关联的打卡信息
     *
     * @var punchParam
     */
    public $punchParam;

    /**
     * @description 三方审批单id，全局唯一
     *
     * @var string
     */
    public $approveId;

    /**
     * @description 审批人员工id
     *
     * @var string
     */
    public $opUserid;
    protected $_name = [
        'userid'     => 'userid',
        'tagName'    => 'tagName',
        'subType'    => 'subType',
        'punchParam' => 'punchParam',
        'approveId'  => 'approveId',
        'opUserid'   => 'opUserid',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->userid) {
            $res['userid'] = $this->userid;
        }
        if (null !== $this->tagName) {
            $res['tagName'] = $this->tagName;
        }
        if (null !== $this->subType) {
            $res['subType'] = $this->subType;
        }
        if (null !== $this->punchParam) {
            $res['punchParam'] = null !== $this->punchParam ? $this->punchParam->toMap() : null;
        }
        if (null !== $this->approveId) {
            $res['approveId'] = $this->approveId;
        }
        if (null !== $this->opUserid) {
            $res['opUserid'] = $this->opUserid;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateApproveRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['userid'])) {
            $model->userid = $map['userid'];
        }
        if (isset($map['tagName'])) {
            $model->tagName = $map['tagName'];
        }
        if (isset($map['subType'])) {
            $model->subType = $map['subType'];
        }
        if (isset($map['punchParam'])) {
            $model->punchParam = punchParam::fromMap($map['punchParam']);
        }
        if (isset($map['approveId'])) {
            $model->approveId = $map['approveId'];
        }
        if (isset($map['opUserid'])) {
            $model->opUserid = $map['opUserid'];
        }

        return $model;
    }
}

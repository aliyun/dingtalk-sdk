<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\CreateApproveRequest\punchParam;
use AlibabaCloud\Tea\Model;

class CreateApproveRequest extends Model
{
    /**
     * @example 341lkfjdkf
     *
     * @var string
     */
    public $approveId;

    /**
     * @example 4243235dfd
     *
     * @var string
     */
    public $opUserid;

    /**
     * @var punchParam
     */
    public $punchParam;

    /**
     * @example 年假
     *
     * @var string
     */
    public $subType;

    /**
     * @example 请假
     *
     * @var string
     */
    public $tagName;

    /**
     * @example fdfi3435
     *
     * @var string
     */
    public $userid;
    protected $_name = [
        'approveId'  => 'approveId',
        'opUserid'   => 'opUserid',
        'punchParam' => 'punchParam',
        'subType'    => 'subType',
        'tagName'    => 'tagName',
        'userid'     => 'userid',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->approveId) {
            $res['approveId'] = $this->approveId;
        }
        if (null !== $this->opUserid) {
            $res['opUserid'] = $this->opUserid;
        }
        if (null !== $this->punchParam) {
            $res['punchParam'] = null !== $this->punchParam ? $this->punchParam->toMap() : null;
        }
        if (null !== $this->subType) {
            $res['subType'] = $this->subType;
        }
        if (null !== $this->tagName) {
            $res['tagName'] = $this->tagName;
        }
        if (null !== $this->userid) {
            $res['userid'] = $this->userid;
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
        if (isset($map['approveId'])) {
            $model->approveId = $map['approveId'];
        }
        if (isset($map['opUserid'])) {
            $model->opUserid = $map['opUserid'];
        }
        if (isset($map['punchParam'])) {
            $model->punchParam = punchParam::fromMap($map['punchParam']);
        }
        if (isset($map['subType'])) {
            $model->subType = $map['subType'];
        }
        if (isset($map['tagName'])) {
            $model->tagName = $map['tagName'];
        }
        if (isset($map['userid'])) {
            $model->userid = $map['userid'];
        }

        return $model;
    }
}

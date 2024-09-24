<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\GetSignRecordByIdResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example ding12345678
     *
     * @var string
     */
    public $corpId;

    /**
     * @example 员工签署中
     *
     * @var string
     */
    public $remark;

    /**
     * @example 1723534265000
     *
     * @var int
     */
    public $signExpireTime;

    /**
     * @example xxxx-合同文件.pdf
     *
     * @var string
     */
    public $signFileName;

    /**
     * @example 1723534265000
     *
     * @var int
     */
    public $signFinishTime;

    /**
     * @example xxxx有限公司
     *
     * @var string
     */
    public $signLegalEntityName;

    /**
     * @example 6fe06f57ab5a45078f3219be8fd829c6
     *
     * @var string
     */
    public $signRecordId;

    /**
     * @example 1723534265000
     *
     * @var int
     */
    public $signStartTime;

    /**
     * @example SIGNING
     *
     * @var string
     */
    public $signStatus;

    /**
     * @example 签署中
     *
     * @var string
     */
    public $signStatusRemarks;

    /**
     * @example CONTRACT
     *
     * @var string
     */
    public $signTemplateType;

    /**
     * @example 400873120394
     *
     * @var string
     */
    public $signUserId;

    /**
     * @example xiaoming
     *
     * @var string
     */
    public $signUserName;

    /**
     * @example ON_LINE
     *
     * @var string
     */
    public $signWay;
    protected $_name = [
        'corpId'              => 'corpId',
        'remark'              => 'remark',
        'signExpireTime'      => 'signExpireTime',
        'signFileName'        => 'signFileName',
        'signFinishTime'      => 'signFinishTime',
        'signLegalEntityName' => 'signLegalEntityName',
        'signRecordId'        => 'signRecordId',
        'signStartTime'       => 'signStartTime',
        'signStatus'          => 'signStatus',
        'signStatusRemarks'   => 'signStatusRemarks',
        'signTemplateType'    => 'signTemplateType',
        'signUserId'          => 'signUserId',
        'signUserName'        => 'signUserName',
        'signWay'             => 'signWay',
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
        if (null !== $this->remark) {
            $res['remark'] = $this->remark;
        }
        if (null !== $this->signExpireTime) {
            $res['signExpireTime'] = $this->signExpireTime;
        }
        if (null !== $this->signFileName) {
            $res['signFileName'] = $this->signFileName;
        }
        if (null !== $this->signFinishTime) {
            $res['signFinishTime'] = $this->signFinishTime;
        }
        if (null !== $this->signLegalEntityName) {
            $res['signLegalEntityName'] = $this->signLegalEntityName;
        }
        if (null !== $this->signRecordId) {
            $res['signRecordId'] = $this->signRecordId;
        }
        if (null !== $this->signStartTime) {
            $res['signStartTime'] = $this->signStartTime;
        }
        if (null !== $this->signStatus) {
            $res['signStatus'] = $this->signStatus;
        }
        if (null !== $this->signStatusRemarks) {
            $res['signStatusRemarks'] = $this->signStatusRemarks;
        }
        if (null !== $this->signTemplateType) {
            $res['signTemplateType'] = $this->signTemplateType;
        }
        if (null !== $this->signUserId) {
            $res['signUserId'] = $this->signUserId;
        }
        if (null !== $this->signUserName) {
            $res['signUserName'] = $this->signUserName;
        }
        if (null !== $this->signWay) {
            $res['signWay'] = $this->signWay;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['remark'])) {
            $model->remark = $map['remark'];
        }
        if (isset($map['signExpireTime'])) {
            $model->signExpireTime = $map['signExpireTime'];
        }
        if (isset($map['signFileName'])) {
            $model->signFileName = $map['signFileName'];
        }
        if (isset($map['signFinishTime'])) {
            $model->signFinishTime = $map['signFinishTime'];
        }
        if (isset($map['signLegalEntityName'])) {
            $model->signLegalEntityName = $map['signLegalEntityName'];
        }
        if (isset($map['signRecordId'])) {
            $model->signRecordId = $map['signRecordId'];
        }
        if (isset($map['signStartTime'])) {
            $model->signStartTime = $map['signStartTime'];
        }
        if (isset($map['signStatus'])) {
            $model->signStatus = $map['signStatus'];
        }
        if (isset($map['signStatusRemarks'])) {
            $model->signStatusRemarks = $map['signStatusRemarks'];
        }
        if (isset($map['signTemplateType'])) {
            $model->signTemplateType = $map['signTemplateType'];
        }
        if (isset($map['signUserId'])) {
            $model->signUserId = $map['signUserId'];
        }
        if (isset($map['signUserName'])) {
            $model->signUserName = $map['signUserName'];
        }
        if (isset($map['signWay'])) {
            $model->signWay = $map['signWay'];
        }

        return $model;
    }
}

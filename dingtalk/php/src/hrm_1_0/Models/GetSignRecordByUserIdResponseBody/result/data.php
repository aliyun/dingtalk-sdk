<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\GetSignRecordByUserIdResponseBody\result;

use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @example ding57935b18bfd13e9735c2f4657eb6378f
     *
     * @var string
     */
    public $corpId;

    /**
     * @example 劳动合同电子签签署备注
     *
     * @var string
     */
    public $remark;

    /**
     * @example 1720775436000
     *
     * @var int
     */
    public $signExpireTime;

    /**
     * @example 小明-劳动合同-20240808.pdf
     *
     * @var string
     */
    public $signFileName;

    /**
     * @example https://n.dingtalk.com/xxx
     *
     * @var string
     */
    public $signFileUrl;

    /**
     * @example 1720775436000
     *
     * @var int
     */
    public $signFinishTime;

    /**
     * @example xxx有限公司
     *
     * @var string
     */
    public $signLegalEntityName;

    /**
     * @example 38bc7b69bb6a46b8a69b9001d5c0bdf3
     *
     * @var string
     */
    public $signRecordId;

    /**
     * @example 1720775436000
     *
     * @var int
     */
    public $signStartTime;

    /**
     * @example FINISHED
     *
     * @var string
     */
    public $signStatus;

    /**
     * @example 法人公司未开通
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
     * @example 660658
     *
     * @var string
     */
    public $signUserId;

    /**
     * @example 小明
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
        'corpId' => 'corpId',
        'remark' => 'remark',
        'signExpireTime' => 'signExpireTime',
        'signFileName' => 'signFileName',
        'signFileUrl' => 'signFileUrl',
        'signFinishTime' => 'signFinishTime',
        'signLegalEntityName' => 'signLegalEntityName',
        'signRecordId' => 'signRecordId',
        'signStartTime' => 'signStartTime',
        'signStatus' => 'signStatus',
        'signStatusRemarks' => 'signStatusRemarks',
        'signTemplateType' => 'signTemplateType',
        'signUserId' => 'signUserId',
        'signUserName' => 'signUserName',
        'signWay' => 'signWay',
    ];

    public function validate() {}

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
        if (null !== $this->signFileUrl) {
            $res['signFileUrl'] = $this->signFileUrl;
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
     * @return data
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
        if (isset($map['signFileUrl'])) {
            $model->signFileUrl = $map['signFileUrl'];
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

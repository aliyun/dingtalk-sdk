<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models;

use AlibabaCloud\Tea\Model;

class SyncSignEventShrinkRequest extends Model
{
    /**
     * @var string
     */
    public $contractBizId;

    /**
     * @var string
     */
    public $corpId;

    /**
     * @var string
     */
    public $extInfoShrink;

    /**
     * @var string
     */
    public $sealTypeShrink;

    /**
     * @var int
     */
    public $signDate;

    /**
     * @var string
     */
    public $signFileListShrink;

    /**
     * @var string
     */
    public $staffId;
    protected $_name = [
        'contractBizId' => 'contractBizId',
        'corpId' => 'corpId',
        'extInfoShrink' => 'extInfo',
        'sealTypeShrink' => 'sealType',
        'signDate' => 'signDate',
        'signFileListShrink' => 'signFileList',
        'staffId' => 'staffId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->contractBizId) {
            $res['contractBizId'] = $this->contractBizId;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->extInfoShrink) {
            $res['extInfo'] = $this->extInfoShrink;
        }
        if (null !== $this->sealTypeShrink) {
            $res['sealType'] = $this->sealTypeShrink;
        }
        if (null !== $this->signDate) {
            $res['signDate'] = $this->signDate;
        }
        if (null !== $this->signFileListShrink) {
            $res['signFileList'] = $this->signFileListShrink;
        }
        if (null !== $this->staffId) {
            $res['staffId'] = $this->staffId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SyncSignEventShrinkRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['contractBizId'])) {
            $model->contractBizId = $map['contractBizId'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['extInfo'])) {
            $model->extInfoShrink = $map['extInfo'];
        }
        if (isset($map['sealType'])) {
            $model->sealTypeShrink = $map['sealType'];
        }
        if (isset($map['signDate'])) {
            $model->signDate = $map['signDate'];
        }
        if (isset($map['signFileList'])) {
            $model->signFileListShrink = $map['signFileList'];
        }
        if (isset($map['staffId'])) {
            $model->staffId = $map['staffId'];
        }

        return $model;
    }
}

<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\SyncSignEventRequest\signFileList;
use AlibabaCloud\Tea\Model;

class SyncSignEventRequest extends Model
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
     * @var string[]
     */
    public $extInfo;

    /**
     * @var string[]
     */
    public $sealType;

    /**
     * @var int
     */
    public $signDate;

    /**
     * @var signFileList[]
     */
    public $signFileList;

    /**
     * @var string
     */
    public $staffId;
    protected $_name = [
        'contractBizId' => 'contractBizId',
        'corpId' => 'corpId',
        'extInfo' => 'extInfo',
        'sealType' => 'sealType',
        'signDate' => 'signDate',
        'signFileList' => 'signFileList',
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
        if (null !== $this->extInfo) {
            $res['extInfo'] = $this->extInfo;
        }
        if (null !== $this->sealType) {
            $res['sealType'] = $this->sealType;
        }
        if (null !== $this->signDate) {
            $res['signDate'] = $this->signDate;
        }
        if (null !== $this->signFileList) {
            $res['signFileList'] = [];
            if (null !== $this->signFileList && \is_array($this->signFileList)) {
                $n = 0;
                foreach ($this->signFileList as $item) {
                    $res['signFileList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->staffId) {
            $res['staffId'] = $this->staffId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SyncSignEventRequest
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
            $model->extInfo = $map['extInfo'];
        }
        if (isset($map['sealType'])) {
            if (!empty($map['sealType'])) {
                $model->sealType = $map['sealType'];
            }
        }
        if (isset($map['signDate'])) {
            $model->signDate = $map['signDate'];
        }
        if (isset($map['signFileList'])) {
            if (!empty($map['signFileList'])) {
                $model->signFileList = [];
                $n = 0;
                foreach ($map['signFileList'] as $item) {
                    $model->signFileList[$n++] = null !== $item ? signFileList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['staffId'])) {
            $model->staffId = $map['staffId'];
        }

        return $model;
    }
}

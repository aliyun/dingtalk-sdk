<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\SendContractCardRequest\contractInfo;
use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\SendContractCardRequest\receivers;
use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\SendContractCardRequest\sender;
use AlibabaCloud\Tea\Model;

class SendContractCardRequest extends Model
{
    /**
     * @description 卡片类型
     *
     * @var string
     */
    public $cardType;

    /**
     * @description 合同信息
     *
     * @var contractInfo
     */
    public $contractInfo;

    /**
     * @description 合同的企业id
     *
     * @var string
     */
    public $corpId;

    /**
     * @description 额外信息
     *
     * @var string[]
     */
    public $extension;

    /**
     * @description 审批实例id
     *
     * @var string
     */
    public $processInstanceId;

    /**
     * @description 接收群id
     *
     * @var string[]
     */
    public $receiveGroups;

    /**
     * @description 接收者
     *
     * @var receivers[]
     */
    public $receivers;

    /**
     * @description 发送者
     *
     * @var sender
     */
    public $sender;

    /**
     * @description 是否同步单聊
     *
     * @var bool
     */
    public $syncSingleChat;
    protected $_name = [
        'cardType'          => 'cardType',
        'contractInfo'      => 'contractInfo',
        'corpId'            => 'corpId',
        'extension'         => 'extension',
        'processInstanceId' => 'processInstanceId',
        'receiveGroups'     => 'receiveGroups',
        'receivers'         => 'receivers',
        'sender'            => 'sender',
        'syncSingleChat'    => 'syncSingleChat',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->cardType) {
            $res['cardType'] = $this->cardType;
        }
        if (null !== $this->contractInfo) {
            $res['contractInfo'] = null !== $this->contractInfo ? $this->contractInfo->toMap() : null;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->extension) {
            $res['extension'] = $this->extension;
        }
        if (null !== $this->processInstanceId) {
            $res['processInstanceId'] = $this->processInstanceId;
        }
        if (null !== $this->receiveGroups) {
            $res['receiveGroups'] = $this->receiveGroups;
        }
        if (null !== $this->receivers) {
            $res['receivers'] = [];
            if (null !== $this->receivers && \is_array($this->receivers)) {
                $n = 0;
                foreach ($this->receivers as $item) {
                    $res['receivers'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->sender) {
            $res['sender'] = null !== $this->sender ? $this->sender->toMap() : null;
        }
        if (null !== $this->syncSingleChat) {
            $res['syncSingleChat'] = $this->syncSingleChat;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SendContractCardRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['cardType'])) {
            $model->cardType = $map['cardType'];
        }
        if (isset($map['contractInfo'])) {
            $model->contractInfo = contractInfo::fromMap($map['contractInfo']);
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['extension'])) {
            $model->extension = $map['extension'];
        }
        if (isset($map['processInstanceId'])) {
            $model->processInstanceId = $map['processInstanceId'];
        }
        if (isset($map['receiveGroups'])) {
            if (!empty($map['receiveGroups'])) {
                $model->receiveGroups = $map['receiveGroups'];
            }
        }
        if (isset($map['receivers'])) {
            if (!empty($map['receivers'])) {
                $model->receivers = [];
                $n                = 0;
                foreach ($map['receivers'] as $item) {
                    $model->receivers[$n++] = null !== $item ? receivers::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['sender'])) {
            $model->sender = sender::fromMap($map['sender']);
        }
        if (isset($map['syncSingleChat'])) {
            $model->syncSingleChat = $map['syncSingleChat'];
        }

        return $model;
    }
}

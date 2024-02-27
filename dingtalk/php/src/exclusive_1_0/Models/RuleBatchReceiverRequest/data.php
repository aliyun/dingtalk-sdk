<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\RuleBatchReceiverRequest;

use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\RuleBatchReceiverRequest\data\attrs;
use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @var string
     */
    public $atAccount;

    /**
     * @var attrs
     */
    public $attrs;

    /**
     * @var string
     */
    public $callbackUrl;

    /**
     * @var string
     */
    public $cardCallbackUrl;

    /**
     * @var mixed[][]
     */
    public $content;

    /**
     * @var bool
     */
    public $isAtAll;

    /**
     * @var string
     */
    public $receiverAccount;

    /**
     * @var int
     */
    public $receiverType;

    /**
     * @var string
     */
    public $serialNumber;
    protected $_name = [
        'atAccount'       => 'atAccount',
        'attrs'           => 'attrs',
        'callbackUrl'     => 'callbackUrl',
        'cardCallbackUrl' => 'cardCallbackUrl',
        'content'         => 'content',
        'isAtAll'         => 'isAtAll',
        'receiverAccount' => 'receiverAccount',
        'receiverType'    => 'receiverType',
        'serialNumber'    => 'serialNumber',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->atAccount) {
            $res['atAccount'] = $this->atAccount;
        }
        if (null !== $this->attrs) {
            $res['attrs'] = null !== $this->attrs ? $this->attrs->toMap() : null;
        }
        if (null !== $this->callbackUrl) {
            $res['callbackUrl'] = $this->callbackUrl;
        }
        if (null !== $this->cardCallbackUrl) {
            $res['cardCallbackUrl'] = $this->cardCallbackUrl;
        }
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->isAtAll) {
            $res['isAtAll'] = $this->isAtAll;
        }
        if (null !== $this->receiverAccount) {
            $res['receiverAccount'] = $this->receiverAccount;
        }
        if (null !== $this->receiverType) {
            $res['receiverType'] = $this->receiverType;
        }
        if (null !== $this->serialNumber) {
            $res['serialNumber'] = $this->serialNumber;
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
        if (isset($map['atAccount'])) {
            $model->atAccount = $map['atAccount'];
        }
        if (isset($map['attrs'])) {
            $model->attrs = attrs::fromMap($map['attrs']);
        }
        if (isset($map['callbackUrl'])) {
            $model->callbackUrl = $map['callbackUrl'];
        }
        if (isset($map['cardCallbackUrl'])) {
            $model->cardCallbackUrl = $map['cardCallbackUrl'];
        }
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['isAtAll'])) {
            $model->isAtAll = $map['isAtAll'];
        }
        if (isset($map['receiverAccount'])) {
            $model->receiverAccount = $map['receiverAccount'];
        }
        if (isset($map['receiverType'])) {
            $model->receiverType = $map['receiverType'];
        }
        if (isset($map['serialNumber'])) {
            $model->serialNumber = $map['serialNumber'];
        }

        return $model;
    }
}

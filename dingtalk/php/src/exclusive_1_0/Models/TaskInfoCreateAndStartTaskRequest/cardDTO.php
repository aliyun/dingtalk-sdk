<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\TaskInfoCreateAndStartTaskRequest;

use AlibabaCloud\Tea\Model;

class cardDTO extends Model
{
    /**
     * @var string
     */
    public $atAccount;

    /**
     * @var string
     */
    public $cardCallbackUrl;

    /**
     * @var mixed
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
    protected $_name = [
        'atAccount'       => 'atAccount',
        'cardCallbackUrl' => 'cardCallbackUrl',
        'content'         => 'content',
        'isAtAll'         => 'isAtAll',
        'receiverAccount' => 'receiverAccount',
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

        return $res;
    }

    /**
     * @param array $map
     *
     * @return cardDTO
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['atAccount'])) {
            $model->atAccount = $map['atAccount'];
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

        return $model;
    }
}

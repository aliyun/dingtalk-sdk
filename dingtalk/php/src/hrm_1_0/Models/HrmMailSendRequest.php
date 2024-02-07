<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\HrmMailSendRequest\mail;
use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\HrmMailSendRequest\operator;
use AlibabaCloud\Tea\Model;

class HrmMailSendRequest extends Model
{
    /**
     * @var mail
     */
    public $mail;

    /**
     * @var operator
     */
    public $operator;
    protected $_name = [
        'mail'     => 'mail',
        'operator' => 'operator',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->mail) {
            $res['mail'] = null !== $this->mail ? $this->mail->toMap() : null;
        }
        if (null !== $this->operator) {
            $res['operator'] = null !== $this->operator ? $this->operator->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return HrmMailSendRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['mail'])) {
            $model->mail = mail::fromMap($map['mail']);
        }
        if (isset($map['operator'])) {
            $model->operator = operator::fromMap($map['operator']);
        }

        return $model;
    }
}

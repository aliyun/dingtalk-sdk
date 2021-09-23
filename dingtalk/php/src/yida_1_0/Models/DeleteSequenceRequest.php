<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\Tea\Model;

class DeleteSequenceRequest extends Model
{
    /**
     * @var string
     */
    public $userId;

    /**
     * @var string
     */
    public $sequence;

    /**
     * @var string
     */
    public $systemToken;

    /**
     * @var string
     */
    public $language;

    /**
     * @var string
     */
    public $appType;
    protected $_name = [
        'userId'      => 'userId',
        'sequence'    => 'sequence',
        'systemToken' => 'systemToken',
        'language'    => 'language',
        'appType'     => 'appType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->sequence) {
            $res['sequence'] = $this->sequence;
        }
        if (null !== $this->systemToken) {
            $res['systemToken'] = $this->systemToken;
        }
        if (null !== $this->language) {
            $res['language'] = $this->language;
        }
        if (null !== $this->appType) {
            $res['appType'] = $this->appType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DeleteSequenceRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['sequence'])) {
            $model->sequence = $map['sequence'];
        }
        if (isset($map['systemToken'])) {
            $model->systemToken = $map['systemToken'];
        }
        if (isset($map['language'])) {
            $model->language = $map['language'];
        }
        if (isset($map['appType'])) {
            $model->appType = $map['appType'];
        }

        return $model;
    }
}

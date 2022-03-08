<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models;

use AlibabaCloud\Tea\Model;

class RecallMessageRequest extends Model
{
    /**
     * @var string
     */
    public $messageId;

    /**
     * @var string
     */
    public $operatorUid;

    /**
     * @var int
     */
    public $type;
    protected $_name = [
        'messageId'   => 'messageId',
        'operatorUid' => 'operatorUid',
        'type'        => 'type',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->messageId) {
            $res['messageId'] = $this->messageId;
        }
        if (null !== $this->operatorUid) {
            $res['operatorUid'] = $this->operatorUid;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return RecallMessageRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['messageId'])) {
            $model->messageId = $map['messageId'];
        }
        if (isset($map['operatorUid'])) {
            $model->operatorUid = $map['operatorUid'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}

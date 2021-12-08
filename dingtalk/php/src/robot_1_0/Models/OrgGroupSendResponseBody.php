<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models;

use AlibabaCloud\Tea\Model;

class OrgGroupSendResponseBody extends Model
{
    /**
     * @description 加密消息id
     *
     * @var string
     */
    public $processQueryKey;
    protected $_name = [
        'processQueryKey' => 'processQueryKey',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->processQueryKey) {
            $res['processQueryKey'] = $this->processQueryKey;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return OrgGroupSendResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['processQueryKey'])) {
            $model->processQueryKey = $map['processQueryKey'];
        }

        return $model;
    }
}

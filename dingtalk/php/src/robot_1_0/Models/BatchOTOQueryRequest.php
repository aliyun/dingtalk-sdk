<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models;

use AlibabaCloud\Tea\Model;

class BatchOTOQueryRequest extends Model
{
    /**
     * @description 消息已读查询标志
     *
     * @var string
     */
    public $processQueryKey;

    /**
     * @description 机器人robotCode
     *
     * @var string
     */
    public $robotCode;
    protected $_name = [
        'processQueryKey' => 'processQueryKey',
        'robotCode'       => 'robotCode',
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
        if (null !== $this->robotCode) {
            $res['robotCode'] = $this->robotCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BatchOTOQueryRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['processQueryKey'])) {
            $model->processQueryKey = $map['processQueryKey'];
        }
        if (isset($map['robotCode'])) {
            $model->robotCode = $map['robotCode'];
        }

        return $model;
    }
}

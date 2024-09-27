<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\SendPersonalMessageResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var string
     */
    public $openTaskId;
    protected $_name = [
        'openTaskId' => 'openTaskId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->openTaskId) {
            $res['openTaskId'] = $this->openTaskId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['openTaskId'])) {
            $model->openTaskId = $map['openTaskId'];
        }

        return $model;
    }
}

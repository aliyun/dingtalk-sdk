<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\UpdateProjectGroupResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 是否成功
     *
     * @var bool
     */
    public $ok;
    protected $_name = [
        'ok' => 'ok',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->ok) {
            $res['ok'] = $this->ok;
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
        if (isset($map['ok'])) {
            $model->ok = $map['ok'];
        }

        return $model;
    }
}

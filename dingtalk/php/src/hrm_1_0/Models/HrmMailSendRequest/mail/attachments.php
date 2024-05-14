<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\HrmMailSendRequest\mail;

use AlibabaCloud\Tea\Model;

class attachments extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 测试.pdf
     *
     * @var string
     */
    public $name;

    /**
     * @description This parameter is required.
     *
     * @example @asdc12312
     *
     * @var string
     */
    public $path;

    /**
     * @description This parameter is required.
     *
     * @example media
     *
     * @var string
     */
    public $type;
    protected $_name = [
        'name' => 'name',
        'path' => 'path',
        'type' => 'type',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->path) {
            $res['path'] = $this->path;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return attachments
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['path'])) {
            $model->path = $map['path'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}

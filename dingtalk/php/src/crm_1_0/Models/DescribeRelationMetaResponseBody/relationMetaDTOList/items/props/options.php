<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\DescribeRelationMetaResponseBody\relationMetaDTOList\items\props;

use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\DescribeRelationMetaResponseBody\relationMetaDTOList\items\props\options\extension;
use AlibabaCloud\Tea\Model;

class options extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var extension
     */
    public $extension;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $key;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $value;

    /**
     * @description This parameter is required.
     *
     * @var bool
     */
    public $warn;
    protected $_name = [
        'extension' => 'extension',
        'key'       => 'key',
        'value'     => 'value',
        'warn'      => 'warn',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->extension) {
            $res['extension'] = null !== $this->extension ? $this->extension->toMap() : null;
        }
        if (null !== $this->key) {
            $res['key'] = $this->key;
        }
        if (null !== $this->value) {
            $res['value'] = $this->value;
        }
        if (null !== $this->warn) {
            $res['warn'] = $this->warn;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return options
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['extension'])) {
            $model->extension = extension::fromMap($map['extension']);
        }
        if (isset($map['key'])) {
            $model->key = $map['key'];
        }
        if (isset($map['value'])) {
            $model->value = $map['value'];
        }
        if (isset($map['warn'])) {
            $model->warn = $map['warn'];
        }

        return $model;
    }
}

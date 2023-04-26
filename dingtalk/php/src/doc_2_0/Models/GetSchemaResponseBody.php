<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models;

use AlibabaCloud\Tea\Model;

class GetSchemaResponseBody extends Model
{
    /**
     * @example 0
     *
     * @var int
     */
    public $revision;

    /**
     * @example "{\"pageVersion\":\"1.0.0\",\"pageSchema\":{\"version\":\"1.0.0\",\"componentsMap\":[],\"componentsTree\":[]}}"
     *
     * @var string
     */
    public $value;
    protected $_name = [
        'revision' => 'revision',
        'value'    => 'value',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->revision) {
            $res['revision'] = $this->revision;
        }
        if (null !== $this->value) {
            $res['value'] = $this->value;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetSchemaResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['revision'])) {
            $model->revision = $map['revision'];
        }
        if (isset($map['value'])) {
            $model->value = $map['value'];
        }

        return $model;
    }
}

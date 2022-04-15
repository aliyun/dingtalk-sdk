<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\InsertBlocksRequest\blocks\paragraph;

use AlibabaCloud\Tea\Model;

class style extends Model
{
    /**
     * @description 标题样式
     *
     * @var string
     */
    public $headingLevel;
    protected $_name = [
        'headingLevel' => 'headingLevel',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->headingLevel) {
            $res['headingLevel'] = $this->headingLevel;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return style
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['headingLevel'])) {
            $model->headingLevel = $map['headingLevel'];
        }

        return $model;
    }
}

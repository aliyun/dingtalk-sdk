<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\DescribeRelationMetaResponseBody\relationMetaDTOList\items\children\props\fields\relateProps\options;

use AlibabaCloud\Tea\Model;

class extension extends Model
{
    /**
     * @var bool
     */
    public $editFreeze;
    protected $_name = [
        'editFreeze' => 'editFreeze',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->editFreeze) {
            $res['editFreeze'] = $this->editFreeze;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return extension
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['editFreeze'])) {
            $model->editFreeze = $map['editFreeze'];
        }

        return $model;
    }
}

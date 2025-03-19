<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\ListCommentsResponseBody\result\commentList;

use AlibabaCloud\Tea\Model;

class content extends Model
{
    /**
     * @var mixed[]
     */
    public $elements;
    protected $_name = [
        'elements' => 'elements',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->elements) {
            $res['elements'] = $this->elements;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return content
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['elements'])) {
            if (!empty($map['elements'])) {
                $model->elements = $map['elements'];
            }
        }

        return $model;
    }
}

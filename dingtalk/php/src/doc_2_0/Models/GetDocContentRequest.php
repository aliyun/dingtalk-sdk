<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models;

use AlibabaCloud\Tea\Model;

class GetDocContentRequest extends Model
{
    /**
     * @example markdown
     *
     * @var string
     */
    public $targetFormat;
    protected $_name = [
        'targetFormat' => 'targetFormat',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->targetFormat) {
            $res['targetFormat'] = $this->targetFormat;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetDocContentRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['targetFormat'])) {
            $model->targetFormat = $map['targetFormat'];
        }

        return $model;
    }
}

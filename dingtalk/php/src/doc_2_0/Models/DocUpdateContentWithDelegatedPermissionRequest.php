<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models;

use AlibabaCloud\Tea\Model;

class DocUpdateContentWithDelegatedPermissionRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example content
     *
     * @var string
     */
    public $content;

    /**
     * @example data_type
     *
     * @var string
     */
    public $dataType;
    protected $_name = [
        'content' => 'content',
        'dataType' => 'dataType',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->dataType) {
            $res['dataType'] = $this->dataType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DocUpdateContentWithDelegatedPermissionRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['dataType'])) {
            $model->dataType = $map['dataType'];
        }

        return $model;
    }
}

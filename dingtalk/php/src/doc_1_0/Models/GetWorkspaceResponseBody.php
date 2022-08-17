<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetWorkspaceResponseBody extends Model
{
    /**
     * @var bool
     */
    public $isDeleted;

    /**
     * @var string
     */
    public $owner;

    /**
     * @var string
     */
    public $url;
    protected $_name = [
        'isDeleted' => 'isDeleted',
        'owner'     => 'owner',
        'url'       => 'url',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->isDeleted) {
            $res['isDeleted'] = $this->isDeleted;
        }
        if (null !== $this->owner) {
            $res['owner'] = $this->owner;
        }
        if (null !== $this->url) {
            $res['url'] = $this->url;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetWorkspaceResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['isDeleted'])) {
            $model->isDeleted = $map['isDeleted'];
        }
        if (isset($map['owner'])) {
            $model->owner = $map['owner'];
        }
        if (isset($map['url'])) {
            $model->url = $map['url'];
        }

        return $model;
    }
}

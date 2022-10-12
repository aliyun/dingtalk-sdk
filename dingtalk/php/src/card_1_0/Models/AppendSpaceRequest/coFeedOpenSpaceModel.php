<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\AppendSpaceRequest;

use AlibabaCloud\Tea\Model;

class coFeedOpenSpaceModel extends Model
{
    /**
     * @description 【必填】标题
     *
     * @var string
     */
    public $title;
    protected $_name = [
        'title' => 'title',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return coFeedOpenSpaceModel
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }

        return $model;
    }
}

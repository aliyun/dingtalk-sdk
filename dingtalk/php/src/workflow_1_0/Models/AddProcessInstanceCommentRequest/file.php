<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\AddProcessInstanceCommentRequest;

use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\AddProcessInstanceCommentRequest\file\attachments;
use AlibabaCloud\Tea\Model;

class file extends Model
{
    /**
     * @description 附件列表。
     *
     * @var attachments[]
     */
    public $attachments;

    /**
     * @description 图片URL地址。
     *
     * @var string[]
     */
    public $photos;
    protected $_name = [
        'attachments' => 'attachments',
        'photos'      => 'photos',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->attachments) {
            $res['attachments'] = [];
            if (null !== $this->attachments && \is_array($this->attachments)) {
                $n = 0;
                foreach ($this->attachments as $item) {
                    $res['attachments'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->photos) {
            $res['photos'] = $this->photos;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return file
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['attachments'])) {
            if (!empty($map['attachments'])) {
                $model->attachments = [];
                $n                  = 0;
                foreach ($map['attachments'] as $item) {
                    $model->attachments[$n++] = null !== $item ? attachments::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['photos'])) {
            if (!empty($map['photos'])) {
                $model->photos = $map['photos'];
            }
        }

        return $model;
    }
}

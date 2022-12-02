<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\GetFamilySchoolConversationMsgResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\GetFamilySchoolConversationMsgResponseBody\messages\mediaModels;
use AlibabaCloud\Tea\Model;

class messages extends Model
{
    /**
     * @description 消息类型，2-图片、202视频、3100富文本消息
     *
     * @var int
     */
    public $contentType;

    /**
     * @description 消息的创建时间
     *
     * @var int
     */
    public $createAt;

    /**
     * @description media文件对象列表
     *
     * @var mediaModels[]
     */
    public $mediaModels;

    /**
     * @description 消息的唯一标识
     *
     * @var string
     */
    public $openMsgId;
    protected $_name = [
        'contentType' => 'contentType',
        'createAt'    => 'createAt',
        'mediaModels' => 'mediaModels',
        'openMsgId'   => 'openMsgId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->contentType) {
            $res['contentType'] = $this->contentType;
        }
        if (null !== $this->createAt) {
            $res['createAt'] = $this->createAt;
        }
        if (null !== $this->mediaModels) {
            $res['mediaModels'] = [];
            if (null !== $this->mediaModels && \is_array($this->mediaModels)) {
                $n = 0;
                foreach ($this->mediaModels as $item) {
                    $res['mediaModels'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->openMsgId) {
            $res['openMsgId'] = $this->openMsgId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return messages
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['contentType'])) {
            $model->contentType = $map['contentType'];
        }
        if (isset($map['createAt'])) {
            $model->createAt = $map['createAt'];
        }
        if (isset($map['mediaModels'])) {
            if (!empty($map['mediaModels'])) {
                $model->mediaModels = [];
                $n                  = 0;
                foreach ($map['mediaModels'] as $item) {
                    $model->mediaModels[$n++] = null !== $item ? mediaModels::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['openMsgId'])) {
            $model->openMsgId = $map['openMsgId'];
        }

        return $model;
    }
}

<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CallMultimodalModelRequest\chatMessageModelList;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CallMultimodalModelRequest\chatMessageModelList\contentList\imageModel;
use AlibabaCloud\Tea\Model;

class contentList extends Model
{
    /**
     * @var imageModel
     */
    public $imageModel;

    /**
     * @var string
     */
    public $text;

    /**
     * @var string
     */
    public $type;
    protected $_name = [
        'imageModel' => 'imageModel',
        'text' => 'text',
        'type' => 'type',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->imageModel) {
            $res['imageModel'] = null !== $this->imageModel ? $this->imageModel->toMap() : null;
        }
        if (null !== $this->text) {
            $res['text'] = $this->text;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return contentList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['imageModel'])) {
            $model->imageModel = imageModel::fromMap($map['imageModel']);
        }
        if (isset($map['text'])) {
            $model->text = $map['text'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}

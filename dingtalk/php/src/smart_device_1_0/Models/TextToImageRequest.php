<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vsmart_device_1_0\Models;

use AlibabaCloud\Tea\Model;

class TextToImageRequest extends Model
{
    /**
     * @var string
     */
    public $modelId;

    /**
     * @example 1
     *
     * @var int
     */
    public $pictureNum;

    /**
     * @example 1024*1024
     *
     * @var string
     */
    public $pictureSize;

    /**
     * @description This parameter is required.
     *
     * @example 帮我生成一个小猫在草坪上奔跑的图片
     *
     * @var string
     */
    public $query;
    protected $_name = [
        'modelId'     => 'modelId',
        'pictureNum'  => 'pictureNum',
        'pictureSize' => 'pictureSize',
        'query'       => 'query',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->modelId) {
            $res['modelId'] = $this->modelId;
        }
        if (null !== $this->pictureNum) {
            $res['pictureNum'] = $this->pictureNum;
        }
        if (null !== $this->pictureSize) {
            $res['pictureSize'] = $this->pictureSize;
        }
        if (null !== $this->query) {
            $res['query'] = $this->query;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return TextToImageRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['modelId'])) {
            $model->modelId = $map['modelId'];
        }
        if (isset($map['pictureNum'])) {
            $model->pictureNum = $map['pictureNum'];
        }
        if (isset($map['pictureSize'])) {
            $model->pictureSize = $map['pictureSize'];
        }
        if (isset($map['query'])) {
            $model->query = $map['query'];
        }

        return $model;
    }
}

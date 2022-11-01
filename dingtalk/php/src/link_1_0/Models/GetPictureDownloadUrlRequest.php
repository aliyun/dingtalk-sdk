<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetPictureDownloadUrlRequest extends Model
{
    /**
     * @description 服务窗机器人图片消息图片下载码。
     * 开发者需要接入服务窗自建机器人后根据图片回调消息内容获取到对应的downloadCode。
     * @var string
     */
    public $downloadCode;

    /**
     * @description 服务窗机器人消息sessionId。
     * 开发者需要接入服务窗自建机器人后通过回调消息获取到的sessionId。
     * @var string
     */
    public $sessionId;
    protected $_name = [
        'downloadCode' => 'downloadCode',
        'sessionId'    => 'sessionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->downloadCode) {
            $res['downloadCode'] = $this->downloadCode;
        }
        if (null !== $this->sessionId) {
            $res['sessionId'] = $this->sessionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetPictureDownloadUrlRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['downloadCode'])) {
            $model->downloadCode = $map['downloadCode'];
        }
        if (isset($map['sessionId'])) {
            $model->sessionId = $map['sessionId'];
        }

        return $model;
    }
}

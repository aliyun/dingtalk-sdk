<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models;

use AlibabaCloud\Tea\Model;

class RobotMessageFileDownloadRequest extends Model
{
    /**
     * @description 机器人收到消息中的下载码，换取临时下载文件的链接使用。
     *
     * @var string
     */
    public $downloadCode;

    /**
     * @description 机器人的robotCode。
     *
     * @var string
     */
    public $robotCode;
    protected $_name = [
        'downloadCode' => 'downloadCode',
        'robotCode'    => 'robotCode',
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
        if (null !== $this->robotCode) {
            $res['robotCode'] = $this->robotCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return RobotMessageFileDownloadRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['downloadCode'])) {
            $model->downloadCode = $map['downloadCode'];
        }
        if (isset($map['robotCode'])) {
            $model->robotCode = $map['robotCode'];
        }

        return $model;
    }
}

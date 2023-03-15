<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\GetFileUploadInfoRequest\option;
use AlibabaCloud\Tea\Model;

class GetFileUploadInfoRequest extends Model
{
    /**
     * @description 可选参数
     *
     * @var option
     */
    public $option;

    /**
     * @description 通过指定上传协议返回不同协议上传所需要的信息
     * HEADER_SIGNATURE: Header加签
     * @var string
     */
    public $protocol;

    /**
     * @description 用户id
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'option'   => 'option',
        'protocol' => 'protocol',
        'unionId'  => 'unionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->option) {
            $res['option'] = null !== $this->option ? $this->option->toMap() : null;
        }
        if (null !== $this->protocol) {
            $res['protocol'] = $this->protocol;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetFileUploadInfoRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['option'])) {
            $model->option = option::fromMap($map['option']);
        }
        if (isset($map['protocol'])) {
            $model->protocol = $map['protocol'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}

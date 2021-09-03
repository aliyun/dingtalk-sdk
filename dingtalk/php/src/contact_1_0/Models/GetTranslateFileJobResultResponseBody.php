<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetTranslateFileJobResultResponseBody extends Model
{
    /**
     * @description 0 任务进行中 1 任务处理成功 2 任务处理失败
     *
     * @var string
     */
    public $status;

    /**
     * @description 文件内容转译成功后的url，需要用户通过oauth2授权登录在用户侧打开
     *
     * @var string
     */
    public $url;
    protected $_name = [
        'status' => 'status',
        'url'    => 'url',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->url) {
            $res['url'] = $this->url;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetTranslateFileJobResultResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['url'])) {
            $model->url = $map['url'];
        }

        return $model;
    }
}

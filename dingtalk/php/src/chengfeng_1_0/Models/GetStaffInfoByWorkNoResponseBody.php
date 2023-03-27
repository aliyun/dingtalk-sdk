<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models\GetStaffInfoByWorkNoResponseBody\content;
use AlibabaCloud\Tea\Model;

class GetStaffInfoByWorkNoResponseBody extends Model
{
    /**
     * @description 员工详情
     *
     * @var content
     */
    public $content;

    /**
     * @description Id of the request
     *
     * @var string
     */
    public $requestId;
    protected $_name = [
        'content'   => 'content',
        'requestId' => 'requestId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->content) {
            $res['content'] = null !== $this->content ? $this->content->toMap() : null;
        }
        if (null !== $this->requestId) {
            $res['requestId'] = $this->requestId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetStaffInfoByWorkNoResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['content'])) {
            $model->content = content::fromMap($map['content']);
        }
        if (isset($map['requestId'])) {
            $model->requestId = $map['requestId'];
        }

        return $model;
    }
}

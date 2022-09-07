<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\AddApproveDentryAuthRequest\fileInfos;
use AlibabaCloud\Tea\Model;

class AddApproveDentryAuthRequest extends Model
{
    /**
     * @description 授权的钉盘文件信息列表。支持批量授权，最大列表长度：10。
     *
     * @var fileInfos[]
     */
    public $fileInfos;

    /**
     * @description 授权的用户userid。
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'fileInfos' => 'fileInfos',
        'userId'    => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->fileInfos) {
            $res['fileInfos'] = [];
            if (null !== $this->fileInfos && \is_array($this->fileInfos)) {
                $n = 0;
                foreach ($this->fileInfos as $item) {
                    $res['fileInfos'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AddApproveDentryAuthRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['fileInfos'])) {
            if (!empty($map['fileInfos'])) {
                $model->fileInfos = [];
                $n                = 0;
                foreach ($map['fileInfos'] as $item) {
                    $model->fileInfos[$n++] = null !== $item ? fileInfos::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}

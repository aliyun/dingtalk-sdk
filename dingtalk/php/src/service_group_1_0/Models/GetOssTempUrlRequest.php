<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetOssTempUrlRequest extends Model
{
    /**
     * @description 访问模式 AUTO(自动，例如在浏览器中如果是图片，PDF等可以在线直接查看，不能在线看时自动下载)、DOWNLOAD（直接下载）
     *
     * @var string
     */
    public $fetchMode;

    /**
     * @description 文件名
     *
     * @var string
     */
    public $fileName;

    /**
     * @description oss文件key
     *
     * @var string
     */
    public $key;

    /**
     * @description 团队开放ID
     *
     * @var string
     */
    public $openTeamId;
    protected $_name = [
        'fetchMode'  => 'fetchMode',
        'fileName'   => 'fileName',
        'key'        => 'key',
        'openTeamId' => 'openTeamId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->fetchMode) {
            $res['fetchMode'] = $this->fetchMode;
        }
        if (null !== $this->fileName) {
            $res['fileName'] = $this->fileName;
        }
        if (null !== $this->key) {
            $res['key'] = $this->key;
        }
        if (null !== $this->openTeamId) {
            $res['openTeamId'] = $this->openTeamId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetOssTempUrlRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['fetchMode'])) {
            $model->fetchMode = $map['fetchMode'];
        }
        if (isset($map['fileName'])) {
            $model->fileName = $map['fileName'];
        }
        if (isset($map['key'])) {
            $model->key = $map['key'];
        }
        if (isset($map['openTeamId'])) {
            $model->openTeamId = $map['openTeamId'];
        }

        return $model;
    }
}

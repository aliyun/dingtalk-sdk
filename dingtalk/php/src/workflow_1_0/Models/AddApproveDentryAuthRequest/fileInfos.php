<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\AddApproveDentryAuthRequest;

use AlibabaCloud\Tea\Model;

class fileInfos extends Model
{
    /**
     * @description 文件ID。
     *
     * @var string
     */
    public $fileId;

    /**
     * @description 钉盘空间spaceId。
     *
     * @var int
     */
    public $spaceId;
    protected $_name = [
        'fileId'  => 'fileId',
        'spaceId' => 'spaceId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->fileId) {
            $res['fileId'] = $this->fileId;
        }
        if (null !== $this->spaceId) {
            $res['spaceId'] = $this->spaceId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return fileInfos
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['fileId'])) {
            $model->fileId = $map['fileId'];
        }
        if (isset($map['spaceId'])) {
            $model->spaceId = $map['spaceId'];
        }

        return $model;
    }
}

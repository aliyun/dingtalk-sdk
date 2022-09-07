<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GrantProcessInstanceForDownloadFileResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 文件下载地址。
     *
     * @var string
     */
    public $downloadUri;

    /**
     * @description 文件ID。
     *
     * @var string
     */
    public $fileId;

    /**
     * @description 钉盘空间ID。
     *
     * @var int
     */
    public $spaceId;
    protected $_name = [
        'downloadUri' => 'downloadUri',
        'fileId'      => 'fileId',
        'spaceId'     => 'spaceId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->downloadUri) {
            $res['downloadUri'] = $this->downloadUri;
        }
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
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['downloadUri'])) {
            $model->downloadUri = $map['downloadUri'];
        }
        if (isset($map['fileId'])) {
            $model->fileId = $map['fileId'];
        }
        if (isset($map['spaceId'])) {
            $model->spaceId = $map['spaceId'];
        }

        return $model;
    }
}

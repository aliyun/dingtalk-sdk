<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetFileDownloadInfoRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $fileIdList;

    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $spaceId;
    protected $_name = [
        'fileIdList' => 'fileIdList',
        'spaceId'    => 'spaceId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->fileIdList) {
            $res['fileIdList'] = $this->fileIdList;
        }
        if (null !== $this->spaceId) {
            $res['spaceId'] = $this->spaceId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetFileDownloadInfoRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['fileIdList'])) {
            if (!empty($map['fileIdList'])) {
                $model->fileIdList = $map['fileIdList'];
            }
        }
        if (isset($map['spaceId'])) {
            $model->spaceId = $map['spaceId'];
        }

        return $model;
    }
}

<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class PublishFileChangeNoticeRequest extends Model
{
    /**
     * @description 钉盘文件id
     *
     * @var string
     */
    public $fileId;

    /**
     * @description 钉盘spaceId
     *
     * @var string
     */
    public $spaceId;

    /**
     * @description 操作人unionId
     *
     * @var string
     */
    public $operatorUnionId;

    /**
     * @description 操作类型: 1-添加 2-修改
     *
     * @var string
     */
    public $operateType;
    protected $_name = [
        'fileId'          => 'fileId',
        'spaceId'         => 'spaceId',
        'operatorUnionId' => 'operatorUnionId',
        'operateType'     => 'operateType',
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
        if (null !== $this->operatorUnionId) {
            $res['operatorUnionId'] = $this->operatorUnionId;
        }
        if (null !== $this->operateType) {
            $res['operateType'] = $this->operateType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return PublishFileChangeNoticeRequest
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
        if (isset($map['operatorUnionId'])) {
            $model->operatorUnionId = $map['operatorUnionId'];
        }
        if (isset($map['operateType'])) {
            $model->operateType = $map['operateType'];
        }

        return $model;
    }
}

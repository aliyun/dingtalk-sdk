<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vflashmeeting_1_0\Models;

use AlibabaCloud\Tea\Model;

class ExportShanhuiToDocRequest extends Model
{
    /**
     * @var string[]
     */
    public $contentEnums;

    /**
     * @var string
     */
    public $parentNodeKey;

    /**
     * @var string
     */
    public $shanhuiKey;

    /**
     * @var string
     */
    public $userId;

    /**
     * @var string
     */
    public $workspaceKey;
    protected $_name = [
        'contentEnums' => 'contentEnums',
        'parentNodeKey' => 'parentNodeKey',
        'shanhuiKey' => 'shanhuiKey',
        'userId' => 'userId',
        'workspaceKey' => 'workspaceKey',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->contentEnums) {
            $res['contentEnums'] = $this->contentEnums;
        }
        if (null !== $this->parentNodeKey) {
            $res['parentNodeKey'] = $this->parentNodeKey;
        }
        if (null !== $this->shanhuiKey) {
            $res['shanhuiKey'] = $this->shanhuiKey;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->workspaceKey) {
            $res['workspaceKey'] = $this->workspaceKey;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ExportShanhuiToDocRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['contentEnums'])) {
            if (!empty($map['contentEnums'])) {
                $model->contentEnums = $map['contentEnums'];
            }
        }
        if (isset($map['parentNodeKey'])) {
            $model->parentNodeKey = $map['parentNodeKey'];
        }
        if (isset($map['shanhuiKey'])) {
            $model->shanhuiKey = $map['shanhuiKey'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['workspaceKey'])) {
            $model->workspaceKey = $map['workspaceKey'];
        }

        return $model;
    }
}

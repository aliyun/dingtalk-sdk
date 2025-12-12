<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetPrivateStoreFileInfosByPageRequest extends Model
{
    /**
     * @example 文档文件:document, 视频:video, 代码文件:text, 链接:link, 音频:audio, 图片:image, 压缩文件:archive, 安装包:app, 其他:other
     *
     * @var string
     */
    public $contentType;

    /**
     * @var int[]
     */
    public $deptIds;

    /**
     * @description This parameter is required.
     *
     * @example 1680493837426
     *
     * @var int
     */
    public $fileCreateTime;

    /**
     * @var string
     */
    public $fileStatus;

    /**
     * @var int
     */
    public $maxResults;

    /**
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $nextToken;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $order;

    /**
     * @example IM:IM, 其他:OTHER, 个人空间:PERSON, 企业内共享:ORG
     *
     * @var string
     */
    public $sceneType;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $targetCorpId;

    /**
     * @var string[]
     */
    public $userIds;
    protected $_name = [
        'contentType' => 'contentType',
        'deptIds' => 'deptIds',
        'fileCreateTime' => 'fileCreateTime',
        'fileStatus' => 'fileStatus',
        'maxResults' => 'maxResults',
        'name' => 'name',
        'nextToken' => 'nextToken',
        'order' => 'order',
        'sceneType' => 'sceneType',
        'targetCorpId' => 'targetCorpId',
        'userIds' => 'userIds',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->contentType) {
            $res['contentType'] = $this->contentType;
        }
        if (null !== $this->deptIds) {
            $res['deptIds'] = $this->deptIds;
        }
        if (null !== $this->fileCreateTime) {
            $res['fileCreateTime'] = $this->fileCreateTime;
        }
        if (null !== $this->fileStatus) {
            $res['fileStatus'] = $this->fileStatus;
        }
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->order) {
            $res['order'] = $this->order;
        }
        if (null !== $this->sceneType) {
            $res['sceneType'] = $this->sceneType;
        }
        if (null !== $this->targetCorpId) {
            $res['targetCorpId'] = $this->targetCorpId;
        }
        if (null !== $this->userIds) {
            $res['userIds'] = $this->userIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetPrivateStoreFileInfosByPageRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['contentType'])) {
            $model->contentType = $map['contentType'];
        }
        if (isset($map['deptIds'])) {
            if (!empty($map['deptIds'])) {
                $model->deptIds = $map['deptIds'];
            }
        }
        if (isset($map['fileCreateTime'])) {
            $model->fileCreateTime = $map['fileCreateTime'];
        }
        if (isset($map['fileStatus'])) {
            $model->fileStatus = $map['fileStatus'];
        }
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['order'])) {
            $model->order = $map['order'];
        }
        if (isset($map['sceneType'])) {
            $model->sceneType = $map['sceneType'];
        }
        if (isset($map['targetCorpId'])) {
            $model->targetCorpId = $map['targetCorpId'];
        }
        if (isset($map['userIds'])) {
            if (!empty($map['userIds'])) {
                $model->userIds = $map['userIds'];
            }
        }

        return $model;
    }
}

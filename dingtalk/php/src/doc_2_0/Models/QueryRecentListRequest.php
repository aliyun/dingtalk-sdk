<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models;

use AlibabaCloud\Tea\Model;

class QueryRecentListRequest extends Model
{
    /**
     * @description 创建人类型。0-全部；1-我创建的；2-他人创建；不填也是查全部。
     *
     * @var int
     */
    public $creatorType;

    /**
     * @description 访问文档类型：0-文字；1-表格；2-PPT；3-白板；6-脑图；7-多维表；不填的话，则默认是所有。
     *
     * @var int
     */
    public $fileType;

    /**
     * @description 每页最大条目数，最大值10。
     *
     * @var int
     */
    public $maxResults;

    /**
     * @description 分页游标，第一页可不传。
     *
     * @var string
     */
    public $nextToken;

    /**
     * @description 操作用户unionId。
     *
     * @var string
     */
    public $operatorId;

    /**
     * @description 最近列表的类型：0-最近访问；1-最近编辑。
     *
     * @var int
     */
    public $recentType;
    protected $_name = [
        'creatorType' => 'creatorType',
        'fileType'    => 'fileType',
        'maxResults'  => 'maxResults',
        'nextToken'   => 'nextToken',
        'operatorId'  => 'operatorId',
        'recentType'  => 'recentType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->creatorType) {
            $res['creatorType'] = $this->creatorType;
        }
        if (null !== $this->fileType) {
            $res['fileType'] = $this->fileType;
        }
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }
        if (null !== $this->recentType) {
            $res['recentType'] = $this->recentType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryRecentListRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['creatorType'])) {
            $model->creatorType = $map['creatorType'];
        }
        if (isset($map['fileType'])) {
            $model->fileType = $map['fileType'];
        }
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }
        if (isset($map['recentType'])) {
            $model->recentType = $map['recentType'];
        }

        return $model;
    }
}

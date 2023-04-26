<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetCustomerTracksByRelationIdResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetCustomerTracksByRelationIdResponseBody\resultList\isvInfo;
use AlibabaCloud\Tea\Model;

class resultList extends Model
{
    /**
     * @var string
     */
    public $content;

    /**
     * @example 华佗
     *
     * @var string
     */
    public $creatorName;

    /**
     * @var string[]
     */
    public $detail;

    /**
     * @example markdown
     *
     * @var string
     */
    public $format;

    /**
     * @example 2022-03-24T09:30Z
     *
     * @var string
     */
    public $gmtCreate;

    /**
     * @var isvInfo
     */
    public $isvInfo;

    /**
     * @var string
     */
    public $title;

    /**
     * @example 201
     *
     * @var int
     */
    public $type;

    /**
     * @example 1
     *
     * @var int
     */
    public $typeGroup;
    protected $_name = [
        'content'     => 'content',
        'creatorName' => 'creatorName',
        'detail'      => 'detail',
        'format'      => 'format',
        'gmtCreate'   => 'gmtCreate',
        'isvInfo'     => 'isvInfo',
        'title'       => 'title',
        'type'        => 'type',
        'typeGroup'   => 'typeGroup',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->creatorName) {
            $res['creatorName'] = $this->creatorName;
        }
        if (null !== $this->detail) {
            $res['detail'] = $this->detail;
        }
        if (null !== $this->format) {
            $res['format'] = $this->format;
        }
        if (null !== $this->gmtCreate) {
            $res['gmtCreate'] = $this->gmtCreate;
        }
        if (null !== $this->isvInfo) {
            $res['isvInfo'] = null !== $this->isvInfo ? $this->isvInfo->toMap() : null;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }
        if (null !== $this->typeGroup) {
            $res['typeGroup'] = $this->typeGroup;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return resultList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['creatorName'])) {
            $model->creatorName = $map['creatorName'];
        }
        if (isset($map['detail'])) {
            $model->detail = $map['detail'];
        }
        if (isset($map['format'])) {
            $model->format = $map['format'];
        }
        if (isset($map['gmtCreate'])) {
            $model->gmtCreate = $map['gmtCreate'];
        }
        if (isset($map['isvInfo'])) {
            $model->isvInfo = isvInfo::fromMap($map['isvInfo']);
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }
        if (isset($map['typeGroup'])) {
            $model->typeGroup = $map['typeGroup'];
        }

        return $model;
    }
}

<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetDbConfigResponseBody extends Model
{
    /**
     * @example {\"dbName\":\"yida_exclusive_pg_db\",\"exclusiveType\":\"DATABASE\",\"maxActive\":1600,\"minIdle\":160,\"password\":\"xxx\",\"sharding\":true,\"type\":\"POSTGRES\",\"url\":\"pgm-bp17c85t9363an74194040.pg.rds.aliyuncs.com:0000\",\"username\":\"yida_xxx\"}
     *
     * @var string
     */
    public $config;

    /**
     * @example ding5d17e3add038d44535c2f4657eb6378f
     *
     * @var string
     */
    public $corpId;

    /**
     * @example 2022-02-23T14:46Z
     *
     * @var string
     */
    public $createTimeGMT;

    /**
     * @example 092824253426603595
     *
     * @var string
     */
    public $creator;

    /**
     * @example ding5d17e3add038d44535c2f4657eb6378f
     *
     * @var string
     */
    public $exclusive;

    /**
     * @example 600001
     *
     * @var string
     */
    public $id;

    /**
     * @example 2023-08-15T10:37Z
     *
     * @var string
     */
    public $modifiedTimeGMT;

    /**
     * @example 5014533041684350
     *
     * @var string
     */
    public $modifier;

    /**
     * @example DATABASE
     *
     * @var string
     */
    public $type;
    protected $_name = [
        'config'          => 'config',
        'corpId'          => 'corpId',
        'createTimeGMT'   => 'createTimeGMT',
        'creator'         => 'creator',
        'exclusive'       => 'exclusive',
        'id'              => 'id',
        'modifiedTimeGMT' => 'modifiedTimeGMT',
        'modifier'        => 'modifier',
        'type'            => 'type',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->config) {
            $res['config'] = $this->config;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->createTimeGMT) {
            $res['createTimeGMT'] = $this->createTimeGMT;
        }
        if (null !== $this->creator) {
            $res['creator'] = $this->creator;
        }
        if (null !== $this->exclusive) {
            $res['exclusive'] = $this->exclusive;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->modifiedTimeGMT) {
            $res['modifiedTimeGMT'] = $this->modifiedTimeGMT;
        }
        if (null !== $this->modifier) {
            $res['modifier'] = $this->modifier;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetDbConfigResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['config'])) {
            $model->config = $map['config'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['createTimeGMT'])) {
            $model->createTimeGMT = $map['createTimeGMT'];
        }
        if (isset($map['creator'])) {
            $model->creator = $map['creator'];
        }
        if (isset($map['exclusive'])) {
            $model->exclusive = $map['exclusive'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['modifiedTimeGMT'])) {
            $model->modifiedTimeGMT = $map['modifiedTimeGMT'];
        }
        if (isset($map['modifier'])) {
            $model->modifier = $map['modifier'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
